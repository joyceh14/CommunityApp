using System;
using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data;

public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }
    public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province>() {
            new Province() {    // 1
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new Province() {    //2
                ProvinceCode="AB",
                ProvinceName="Alberta",
            },
            new Province() {    // 3
                ProvinceCode="ON",
                ProvinceName="Ontario",
            },
            new Province() {    // 4
                ProvinceCode="QC",
                ProvinceName="Quebec",
            },
            new Province() {    // 5
                ProvinceCode="MB",
                ProvinceName="Manitoba",
            },
        };

        return provinces;
    }

    public static List<City> GetCities() {
        List<City> cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Surrey",
                Population = 568322, 
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Burnaby",
                Population = 249125, 
                ProvinceCode = "BC"
            },
            new City {
                CityId = 3,
                CityName = "Calgary",
                Population = 1306784, 
                ProvinceCode = "AB"
            },
            new City {
                CityId = 4,
                CityName = "Edmonton",
                Population = 1010899, 
                ProvinceCode = "AB"
            },
            new City {
                CityId = 5,
                CityName = "Toronto",
                Population = 2794356, 
                ProvinceCode = "ON"
            },
            new City {
                CityId = 6,
                CityName = "Ottawa",
                Population = 1017449, 
                ProvinceCode = "ON"
            },
            new City {
                CityId = 7,
                CityName = "Montreal",
                Population = 1762949, 
                ProvinceCode = "QC"
            },
            new City {
                CityId = 8,
                CityName = "Quebec City",
                Population = 549459, 
                ProvinceCode = "QC"
            },
            new City {
                CityId = 9,
                CityName = "Winnipeg",
                Population = 749607, 
                ProvinceCode = "MB"
            },
            new City {
                CityId = 10,
                CityName = "Brandon",
                Population = 26234, 
                ProvinceCode = "MB"
            },
        };

        return cities;
    }
}