﻿using AutoMapper;
using DeliveryApp.API.Models.DTO;
using DeliveryApp.Models.Data;
using DeliveryApp.Services.Contracts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.API.ControllersAPI
{
    [ApiController]
    [Route("delivery-app/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IMapper _mapper;
        private readonly IClientService clientService;
        private readonly IFavoritesService favoritesService;
        private readonly ICategoryService categoryService;

        public ProductsController(IProductService productService, IMapper mapper,
            IClientService clientService, IFavoritesService favoritesService, ICategoryService categoryService)
        {
            this.productService = productService;
            _mapper = mapper;
            this.clientService = clientService;
            this.favoritesService = favoritesService;
            this.categoryService = categoryService;
        }

        [EnableCors("AllowAll")]
        [HttpGet]
        public ActionResult<IEnumerable<ProductForHomeDto>> GetProducts(string searchQuery, int clientId)
        {
            var products = productService.GetAllProducts(searchQuery);
            if (products == null)
            {
                return NotFound();
            }

            //Must be moved to product details action 
            var favorites = favoritesService.GetFavoriteProducts(clientId);
            var productsForHome = new List<ProductForHomeDto>();
            foreach (var prod in products)
            {
                bool isFavorite = false;
                foreach (var favorite in favorites)
                {
                    if (prod.Id == favorite.ProductId)
                    {
                        isFavorite = true;
                    }
                }
                productsForHome.Add(new ProductForHomeDto
                {
                    Id = prod.Id,
                    ImageBase64 = prod.ProductImages.FirstOrDefault().ImageBase64,
                    Name = prod.Name,
                    Price = prod.Price,
                    IsFavorite = isFavorite
                });
            }

            //return Ok(_mapper.Map<IEnumerable<ProductForHomeDto>>(products));
            return Ok(productsForHome);
        }

        [EnableCors("AllowAll")]
        [HttpGet("category")]
        public ActionResult<IEnumerable<ProductForHomeDto>> GetProductsByCategoryId(int id)
        {
            var category = categoryService.GetCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }

            var products = productService.GetProductsByCategory(category);
            if (products == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<ProductForHomeDto>>(products));

        }

        [EnableCors("AllowAll")]
        [HttpGet("{productId}", Name = "GetProduct")]
        public ActionResult<ProductDetailsDto> GetProduct(int productId)
        {
            var product = productService.GetProductById(productId);
            if (product == null)
            {
                return NotFound();
            }

            ICollection<byte[]> imagesBase64 = new List<byte[]>();
            foreach (var img in product.ProductImages)
            {
                imagesBase64.Add(img.ImageBase64);
            }

            //Could be optimized with IMapper
            ProductDetailsDto productDetails = new ProductDetailsDto
            {
                Description = product.Description,
                Id = product.Id, Name = product.Name,
                Price = product.Price,
                ProductImagesBase64 = imagesBase64
            };


            return Ok(productDetails);
        }

        [EnableCors("AllowAll")]
        [HttpGet("favorites/clients/{clientId}")]
        public ActionResult<IEnumerable<ProductForHomeDto>> GetFavoriteProducts(int clientId)
        {
            var client = clientService.GetClientById(clientId);
            if (client == null)
            {
                return NotFound();
            }

            var favorites = favoritesService.GetFavoriteProducts(clientId);
            var favoriteProducts = new List<ProductForHomeDto>();
            foreach(var favorite in favorites)
            {
                var product = productService.GetProductById(favorite.ProductId);
                if(product != null)
                {
                    favoriteProducts.Add(new ProductForHomeDto
                    {
                        Id = product.Id,
                        ImageBase64 = product.ProductImages.FirstOrDefault().ImageBase64,
                        Name = product.Name,
                        Price = product.Price,
                        IsFavorite = true
                    });
                }
            }
            return Ok(favoriteProducts);
        }

        [EnableCors("AllowAll")]
        [HttpPost("like-product")]
        public ActionResult<ProductForHomeDto> LikeProduct(FavoriteForCreationDto favoriteDto)
        {
            var client = clientService.GetClientById(favoriteDto.ClientId);
            var product = productService.GetProductById(favoriteDto.ProductId);

            if (client == null || product == null)
            {
                return NotFound();
            }

            var favorite = favoritesService.AddProductToFavorites(new Favorites { ProductId = favoriteDto.ProductId, ClientId = favoriteDto.ClientId });

            return CreatedAtRoute("GetProduct", new { productId = product.Id }, favorite);
        }

        [EnableCors("AllowAll")]
        [HttpPost("dislike-product")]
        public ActionResult<ProductForHomeDto> DislikeProduct(FavoriteForCreationDto favoriteDto)
        {
            var client = clientService.GetClientById(favoriteDto.ClientId);
            var product = productService.GetProductById(favoriteDto.ProductId);
            if (client == null || product == null)
            {
                return NotFound();
            }

            var favorite = favoritesService.RemoveProductFromFavorites(new Favorites { ProductId = favoriteDto.ProductId, ClientId = favoriteDto.ClientId });
            if(favorite == null)
            {
                return NotFound();
            }
            
            return Ok(favorite);
        }
    }
}
