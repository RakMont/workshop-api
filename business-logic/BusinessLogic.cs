using System;
using workshop_api.business_logic.interfaces;
using System.Collections.Generic;
using workshop_api.business_logic.entities;
namespace workshop_api.business_logic
{
    public class BusinessLogic : IBusinessLogic
    {
        private  IWorkshopRepository _repository = new StaticRepository();
        
        public string menssage(){
           return "Hola esto funciona"; 
        }

        public List<Workshop> getWorkshops(){
            return _repository.get_all_Workshops();
        }
        public Workshop getOneWorkshop(int id){
            return _repository.get_one_Workshop(id);
        }

        public void create_WorkShop(Workshop workshop){
            _repository.create_WorkShop(workshop);
        }

    }
}