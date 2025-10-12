using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.BL.Seeds
{
    public class DefaultCurrency(CurrencySeedServicesBL _curSeedServicesBL)
    {
        public async Task SeedDefaultCurrency()
        {
            await _curSeedServicesBL.SeedDefaultCurrency();
        }
    }
}