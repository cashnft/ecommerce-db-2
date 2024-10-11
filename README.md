## manual rollback instructions

To revert the manual migrations you can use following sql commands:

- To rollback the `Products` table:
  DROP TABLE IF EXISTS Products;

- To rollback the `Categories` table:
  DROP TABLE IF EXISTS Categories;

- To rollback the `ProductRatings` table:
  DROP TABLE IF EXISTS ProductRatings;