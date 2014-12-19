using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceInterfaces;
using Entity;
using DALInterfaces;
using DTO;

namespace Services
{
    public class ItemService : IItemService
    {
         private IAppErrors modelerrors;
        private IItemDataAccess  repository;

        public ItemService(IAppErrors modelstate, IItemDataAccess repository)
        {
            this.modelerrors = modelstate;
            this.repository = repository;
        }

        public bool AddNewExam(ItemDTO ex)
        {
            if (this.Validate(ex))
            {
                repository.AddNew(ex);
                return true;
            }
            return false;
        }

        public bool UpdateExam(ItemDTO ex)
        {
            if (this.Validate(ex))
            {
                repository.AddNew(ex);
                return true;
            }
            return false;
        }

        public bool DeleteExam(int itemid)
        {
            repository.Delete(itemid);
            return true;
        }

        public IEnumerable<ItemDTO> GetItems()
        {
            return repository.GetItems();
        }

        public bool Validate(ItemDTO item)
        {
            if (item.Description == null || item.Description == "")
                modelerrors.AddError("ExamName", "Please Enter Exam Name");
            if (item.Qty == 0)
                modelerrors.AddError("PassMark", "Invalid Pass Mark");

            return modelerrors.IsValid;
        }
    }
}
