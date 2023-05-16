SELECT 
p.Name AS 'Product name',
c.Name AS 'Category name'
FROM Products AS p
LEFT JOIN ProductsCategories AS pc
ON p.Id = pc.ProductId,
LEFT JOIN Categorys AS c
ON pc.CategoryId = c.Id;