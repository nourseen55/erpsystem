

namespace Erp.BL.SevicesBL
{
    public  class CurrencySeedServicesBL(IUnitOfWork _unitOfWork)
    {
        public async Task SeedDefaultCurrency (){
            int count = 1;
            foreach (eCurrency c in (Enum.GetValues(typeof(eCurrency))))
            {
                var exisitingCurrency=await _unitOfWork.Repository<Currency>().ExistAsync(x=>x.Name==c.ToString());
                if (!exisitingCurrency)
                {
                    count++;
                    await _unitOfWork.Repository<Currency>().SaveAsync(new Currency {
                        Id = count,
                        Name = c.ToString(),
                        Code = c.ToString()
                    });
                    
                }
            }
            await _unitOfWork.CompleteAsync();

        }
    }
}
