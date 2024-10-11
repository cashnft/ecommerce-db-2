# Ecommerce database Migration Project
This project involves setting zp and managing database schemasch for an ecommerce platform it includes manual and automates sql migrations with er core.

## Setup Instructions
- clone my repository:

git clone https://github.com/cashnft/ecommerce-db-2.git
- Navigate to the pproject folder:

cd ecommerce-db-2/EcommerceApp
- restore .net dependencies:

dotnet restore
- run the project via:

dotnet run
- apply ef core and update the db:

dotnet ef database update


## Manual migrations documentation

the sql scripts are used to manually set up the initial db schema

- create_products_table.sql: creates the products table
- add_categories_table.sql: adds the categories table and updates products to include a category id
- add_product_ratings_table.sql: adds the product ratings for the user ratings


## EF Core Migrations Documentation

The db can be set up via the er core migrations

- initialCreate adds the products categories and product rating tables

to apply the ef core migrations you need to run:

dotnet ef database update

## manual rollback instructions

To revert the manual migrations you can use following sql commands:

- To rollback the `Products` table:
  DROP TABLE IF EXISTS Products;

- To rollback the `Categories` table:
  DROP TABLE IF EXISTS Categories;

- To rollback the `ProductRatings` table:
  DROP TABLE IF EXISTS ProductRatings;


## EF Core Migrations

To rollback ef core migrations:

- roll back to the last migration: dotnet ef database update (previous migration name)

- remove the last migration: dotnet ef migrations remove

