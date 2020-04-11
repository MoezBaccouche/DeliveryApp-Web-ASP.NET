﻿using DeliveryApp.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Services.Contracts
{
    public interface ICartProductService
    {
        CartProduct AddProduct(CartProduct newCartProduct);
        CartProduct RemoveProduct(CartProduct newCartProduct);
        //Removes all the products from the user cart
        IEnumerable<CartProduct> RemoveAllProducts(int userId);
        IEnumerable<CartProduct> GetCartProducts(int userId);
        CartProduct EditProduct(CartProduct newCartProduct);
        
    }
}
