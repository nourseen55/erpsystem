using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.BL.Seeds
{
    public class DefaultUnit(UnitSeedServicesBL _unitSeedServicesBL)
    {
        public async Task SeedDefaultUnit()
        {
            await _unitSeedServicesBL.SeedDefaultUnit();
        }
    }
}