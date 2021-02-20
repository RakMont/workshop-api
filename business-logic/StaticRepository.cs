using System;
using System.Collections.Generic;
using workshop_api.business_logic.interfaces;
using workshop_api.business_logic.entities;
namespace workshop_api.business_logic
{
    public class StaticRepository:IWorkshopRepository
    {
        public List<Workshop> workshops = new List<Workshop>() { 
                new Workshop(){ Id = 1, Name="Bock",Status="Scheduled"},
                new Workshop(){ Id = 2, Name="Phone",Status="Postponed"},
                new Workshop(){ Id = 3, Name="Laptop",Status="Cancelled"},
                new Workshop(){ Id = 4, Name="Phone",Status="Postponed"}
            };
        public List<Workshop> get_all_Workshops(){
            
            return workshops;
        }
        public Workshop get_one_Workshop(int id){
            Workshop workshop=workshops.Find(x => x.Id==id);
            return workshop;
        }
        public void create_WorkShop(Workshop workshop){
            workshops.Add(workshop);
        }
        public void update_WorkShop(Workshop workshop){

        }
        public void delete_workshop(int id){

        }
        public void cancel_workshop(){

        }
        public void pospone_workshope(){}
        
    }
}