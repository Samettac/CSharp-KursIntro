--ANSII
--Select
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'


--case insensitive
select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products where CategoryID = 1 order by UnitPrice asc   --ascending   --artan
                                                             --desc  --descending  --azalan

select count(*) Adet from Products where CategoryID = 2

select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

--Dersin ödevi: 
/*Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.
İpucu : Group by kullanılacak
İpucu : Products, Orders, Order Details tabloları join edilecek.
İpucu : Sum kullanılacak.*/

select p.ProductName as 'Ürün Adı', sum(od.UnitPrice*od.Quantity) as 'Kazanılan Toplam Miktar' 
from Products p inner join [Order Details] od 
on od.ProductID = p.ProductID
inner join Orders o
on o.OrderID = od.OrderID
group by ProductName
order by sum(od.UnitPrice*od.Quantity)