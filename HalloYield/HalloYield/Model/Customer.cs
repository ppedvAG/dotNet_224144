﻿namespace HalloYield.Model;

public class Customer
{
    public string CustomerID { get; set; } = string.Empty;

    public string? CompanyName { get; set; } = string.Empty;

    public string ContactName { get; set; } = string.Empty;

    public string ContactTitle { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public string Country { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string? Fax { get; set; }
}