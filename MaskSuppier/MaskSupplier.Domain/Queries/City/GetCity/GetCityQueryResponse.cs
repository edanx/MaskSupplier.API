﻿namespace MaskSupplier.Domain.Queries.City.GetCity
{
    public class GetCityQueryResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public int Infecteds { get; set; }
        public string Risk { get; set; }
    }
}
