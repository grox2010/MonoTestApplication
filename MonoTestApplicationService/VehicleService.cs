using System;

namespace MonoTestApplicationService
{
    
    public class VehicleService
    {
        //•	VehicleMake (Id,Name,Abrv) e.g. BMW,Ford,Volkswagen,
	    //VehicleModel(Id, MakeId, Name, Abrv) e.g. 128,325,X5(BWM), 
        //•	VehicleService class - CRUD for Make and Model (Sorting, Filtering & Paging)
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}
