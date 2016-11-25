using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace LinkList
{
    [TestFixture]
    class Testing
    {
        [Test]
        public void InsertBeginning()
        {
            LinkedList list = new LinkedList();

            list.InsertBeginning(1);
            Assert.That(list.Length(), Is.EqualTo(1));

        }
		[Test]
		public void InsertAfter()
		{
			LinkedList list = new LinkedList();
			list.InsertAfter(1);
			Assert.That(list.Length(), Is.EqualTo(2));
			
		}




    }
}
