using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InventorySystem1._0;

namespace testunit1
{
    [TestFixture]
    public class Class1
    {
        frmUsers testUser = new frmUsers();
        ktra kt = new ktra();
        [Test]
        public void ktr0a()
        {
            //bool x = testUser.empty("", "a", "b");
            bool x = kt.empty("", "a", "b");

            Assert.IsTrue(x);
        }
    }
}
