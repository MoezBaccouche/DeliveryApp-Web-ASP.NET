﻿using DeliveryApp.Models.Data;
using DeliveryApp.Services.Contracts;
using PFEGestionConges.Data.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Services.Implementations
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> repoLocations;

        public LocationService(IRepository<Location> repoLocations)
        {
            this.repoLocations = repoLocations;
        }

        public Location AddLocation(Location newLocation)
        {
            if(newLocation != null)
            {
                newLocation = repoLocations.Insert(newLocation);
            }
            return newLocation;
        }

        public Location DeleteLocation(int id)
        {
            var location = repoLocations.TableNoTracking
                .Where(l => l.Id == id)
                .FirstOrDefault();

            if(location != null)
            {
                repoLocations.Delete(location);
            }

            return location;
        }

        public Location GetLocationById(int id)
        {
            var location = repoLocations.TableNoTracking.Where(l => l.Id == id).FirstOrDefault();
            return location;
        }

        public Location UpdateLocation(Location newLocation)
        {
            if(newLocation != null)
            {
                repoLocations.Update(newLocation);
            }

            return newLocation;
        }
    }
}
