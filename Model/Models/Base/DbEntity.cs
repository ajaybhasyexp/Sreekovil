using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivineAccounts.Model.Models.Base
{
    public abstract class DbEntity
    {
        /// <summary>
        /// Abstract method for defining ModelBuilder
        /// </summary>
        /// <param name="builder">Mobel Builder</param>
        public abstract void Define(DbModelBuilder builder);
    }
}
