using ShopProject.Abstract;
using ShopProject.Domeins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Data
{
    public class SimpleRepository : IShopRepository
    {
        public IQueryable<Product> Products =>
            new List<Product>()
            {
                new Product()
                {
                    idCharacteristics = 1,
                    idSubcategory = 1,
                    description = "Плита для каждой кухни",
                    count = 30,
                    image = "-",
                    manufacturer = "Bork",
                    model = "PG10",
                    price = 50000
                },
                new Product()
                {
                    idCharacteristics = 2,
                    idSubcategory = 2,
                    description = "Микроволновка для каждой кухни",
                    count = 50,
                    image = "-",
                    manufacturer = "Bork",
                    model = "MG10",
                    price = 15000
                },
                new Product()
                {
                    idCharacteristics = 3,
                    idSubcategory = 3,
                    description = "Мощьный ноутбук для дома",
                    count = 10,
                    image = "-",
                    manufacturer = "HP",
                    model = "1000L",
                    price = 70000
                },
                new Product()
                {
                    idCharacteristics = 4,
                    idSubcategory = 4,
                    description = "FullHD монитор",
                    count = 40,
                    image = "-",
                    manufacturer = "Philips",
                    model = "HD9",
                    price = 10000
                },
                new Product()
                {
                    idCharacteristics = 5,
                    idSubcategory = 5,
                    description = "С этим пылесосом уброка легкой",
                    count = 10,
                    image = "-",
                    manufacturer = "Keng",
                    model = "Rool",
                    price = 34000
                },
                new Product()
                {
                    idCharacteristics = 6,
                    idSubcategory = 6,
                    description = "Эта швабра пройдет в любой угол",
                    count = 5,
                    image = "-",
                    manufacturer = "Foorle",
                    model = "FL76",
                    price = 5000
                },
            }.AsQueryable();

        public IQueryable<Category> Categories =>
            new List<Category>()
            {
                new Category()
                {
                    name = "Кухонная техника"
                },
                new Category()
                {
                    name = "Компьютеры"
                },
                new Category()
                {
                    name = "Техника для уборки"
                }
            }.AsQueryable();

        public IQueryable<Subcategory> Subcategories =>
            new List<Subcategory>()
            {
                new Subcategory()
                {
                    idCategory = 1,
                    name = "Плиты"
                },
                new Subcategory()
                {
                    idCategory = 1,
                    name = "Микроволновки"
                },
                new Subcategory()
                {
                    idCategory = 2,
                    name = "Ноутбуки"
                },
                new Subcategory()
                {
                    idCategory = 2,
                    name = "Мониторы"
                },
                new Subcategory()
                {
                    idCategory = 3,
                    name = "Пылесосы"
                },
                new Subcategory()
                {
                    idCategory = 3,
                    name = "Швабры"
                }
            }.AsQueryable();

        public IQueryable<Characteristic> Characteristics =>
            new List<Characteristic>()
            {
                new Characteristic()
                {
                    color = "Чёрный",
                    size = "60х100х60",
                    weight = "50кг"
                },
                new Characteristic()
                {
                    color = "Чёрный",
                    size = "60х30х30",
                    weight = "10кг"
                },
                new Characteristic()
                {
                    color = "Белый",
                    size = "60х5х60",
                    weight = "3кг"
                },
                new Characteristic()
                {
                    color = "Чёрный",
                    size = "60х30х2",
                    weight = "1кг"
                },
                new Characteristic()
                {
                    color = "Красный",
                    size = "20х20х40",
                    weight = "4кг"
                },
                new Characteristic()
                {
                    color = "Белый",
                    size = "5х100х5",
                    weight = "1кг"
                },
            }.AsQueryable();
    }
}
