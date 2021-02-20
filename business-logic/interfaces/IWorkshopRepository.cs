using System;
using System.Collections.Generic;
using workshop_api.business_logic.entities;
namespace workshop_api.business_logic.interfaces
{
    public interface IWorkshopRepository
    {
        List<Workshop> get_all_Workshops();
        Workshop get_one_Workshop(int id);
        void create_WorkShop(Workshop workshop);
        void update_WorkShop(Workshop workshop);
        void delete_workshop(int id);
        void cancel_workshop();
        void pospone_workshope();
    }
}