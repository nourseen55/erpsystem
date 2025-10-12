

namespace Erp.BL.SevicesBL
{
    public  class UnitSeedServicesBL(IUnitOfWork _unitOfWork)
    {
        public async Task SeedDefaultUnit (){
            int count = 1;
            foreach (eUnit unit in (Enum.GetValues(typeof(eUnit))))
            {
                var exisitingUnit=await _unitOfWork.Repository<Unit>().ExistAsync(x=>x.Name==unit.ToString());
                if (!exisitingUnit)
                {
                    count++;
                    await _unitOfWork.Repository<Unit>().SaveAsync(new Unit {
                        Id = count,
                        Name = unit.ToString(),
                        Quantity=count,
                    });
                    
                }
            }
            await _unitOfWork.CompleteAsync();

        }
    }
}
