using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TPEFCoreApp.AutoGen;

[Index("CustomerId", Name = "CustomerId")]
[Index("CustomerId", Name = "CustomersOrders")]
[Index("EmployeeId", Name = "EmployeeId")]
[Index("EmployeeId", Name = "EmployeesOrders")]
[Index("OrderDate", Name = "OrderDate")]
[Index("ShipPostalCode", Name = "ShipPostalCode")]
[Index("ShippedDate", Name = "ShippedDate")]
[Index("ShipVia", Name = "ShippersOrders")]
public partial class Order
{
    [Key]
    public int OrderId { get; set; }

    [Column(TypeName = "nchar (5)")]
    public string? CustomerId { get; set; }

    [Column(TypeName = "INT")]
    public int? EmployeeId { get; set; }

    [Column(TypeName = "datetime")]
    public string? OrderDate { get; set; }

    [Column(TypeName = "datetime")]
    public string? RequiredDate { get; set; }

    [Column(TypeName = "datetime")]
    public string? ShippedDate { get; set; }

    [Column(TypeName = "INT")]
    public int? ShipVia { get; set; }

    [Column(TypeName = "money")]
    public double? Freight { get; set; }

    [Column(TypeName = "nvarchar (40)")]
    public string? ShipName { get; set; }

    [Column(TypeName = "nvarchar (60)")]
    public string? ShipAddress { get; set; }

    [Column(TypeName = "nvarchar (15)")]
    public string? ShipCity { get; set; }

    [Column(TypeName = "nvarchar (15)")]
    public string? ShipRegion { get; set; }

    [Column(TypeName = "nvarchar (10)")]
    public string? ShipPostalCode { get; set; }

    [Column(TypeName = "nvarchar (15)")]
    public string? ShipCountry { get; set; }
}
