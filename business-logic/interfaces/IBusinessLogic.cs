using System.Collections.Generic;
using workshop_api.business_logic.entities;

namespace workshop_api.business_logic.interfaces
{
    public interface IBusinessLogic
    {
        List<Workshop> getWorkshops();
        Workshop getOneWorkshop(int id);

        void create_WorkShop(Workshop workshop);

         string menssage();

    }
}