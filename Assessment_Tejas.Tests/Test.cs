using NUnit.Framework;
using System;
using AssesmentTejas.ViewModel;
using System.Threading.Tasks;
using AssesmentTejas.Model;

namespace Assessment_Tejas.Tests
{
    [TestFixture()]
    public class Test
    {
        private PeopleListViewModel _peopleListViewModel;
        private DetailPageViewModel _detailPageViewModel;

        [Test()]
        public void TestCase()
        {
            _peopleListViewModel = new PeopleListViewModel();
            _detailPageViewModel = new DetailPageViewModel();
        }

        [Test]
        public async Task GetResponseFromServer_WhenCalled_ShoudlgetResponse()
        {
            Assert.Null(await _peopleListViewModel.GetResponseFromServer());
        }

        [Test]
        public void ValidateUser_WhenClicked_ShoudlValidateSAUser()
        {
            Person person = new Person();
            person.id_citizem = "8001015009087";
            Assert.IsTrue(_detailPageViewModel.Validate_SA_ID(person.id_citizem));
        }
    }
}
