using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProject.Tests {
    [TestFixture]
    class EloadasTest {

		[TestCase]
		public void HibasErtekkelValoInicializalas() {
            Assert.Throws<ArgumentException>(() => {
                var test = new Eloadas(0,0);
            });
        }

		[TestCase]
		public void UjEloadasSzabadhelyei() {
            var test = new Eloadas(2, 2);
            Assert.AreEqual(4, test.SzabadHelyek, "A férőhelyek száma hibás");
        }

        [TestCase]
        public void SzabadHelyek() {
            var test = new Eloadas(2, 2);
            test.Lefoglal();
            Assert.AreEqual(3, test.SzabadHelyek, "A férőhelyek száma hibás");
        }

		[TestCase]
        public void SzabadHelyekTeli() {
            var test = new Eloadas(2, 2);
            test.Lefoglal();
            test.Lefoglal();
            test.Lefoglal();
            test.Lefoglal();
            Assert.AreEqual(0, test.SzabadHelyek, "A férőhelyek száma hibás");
        }

        [TestCase]
        public void SzabadHelyekMinusz() {
            var test = new Eloadas(2, 2);
            Assert.Greater(test.SzabadHelyek, -1, "A férőhelyek száma hibás");
        }

        [TestCase]
        public void TeliEloadas() {
            var test = new Eloadas(2, 2);
            test.Lefoglal();
            test.Lefoglal();
            test.Lefoglal();
            test.Lefoglal();
            Assert.AreEqual(true, test.Teli, "Teli előadás nem teli.");
        }

		[TestCase]
        public void NemTeliEloadas() {
            var test = new Eloadas(2, 2);
            test.Lefoglal();
            test.Lefoglal();
            Assert.AreEqual(false, test.Teli, "Nem teli előadás teli.");
        }

        [TestCase]
        public void TeliNull() {
            var test = new Eloadas(2, 2);
            Assert.AreNotEqual(null, test.Teli, "Igaz-hamis változó null.");
        }

        [TestCase]
        public void HibasFoglaltTeszt() {
            var test = new Eloadas(2, 2);
            test.Lefoglal();
            Assert.Throws<ArgumentException>(() => {
                test.Foglalt(0, 0);
            });
        }

        [TestCase]
		public void FoglaltTeszt() {
            var test = new Eloadas(2, 2);
            test.Lefoglal();
            Assert.AreEqual(true, test.Foglalt(1, 1), "Lefoglalt hely nem foglalt.");
        }

        [TestCase]
        public void FoglaltTesztNull() {
            var test = new Eloadas(2, 2);
            test.Lefoglal();
            Assert.AreNotEqual(null, test.Foglalt(1, 1), "Igaz-hamis változó null.");
        }

        [TestCase]
        public void FoglaltTesztOutOfRange() {
            var test = new Eloadas(2, 2);
            Assert.Throws<IndexOutOfRangeException>(() => {
                test.Foglalt(10, 10);
            });
        }

		[TestCase]
        public void LefoglalNull() {
            var test = new Eloadas(2, 2);
            Assert.AreNotEqual(null, test.Lefoglal(), "Igaz-hamis változó null.");
        }
    }
}
