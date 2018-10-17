using System;
using System.Collections.Generic;

namespace CricScoreInfo.Web.Shared.WebApiCaller
{
  public class MockWebApi
  {
    public List<MockApiResponseModel> Responses;

    public MockWebApi()
    {
      Responses = new List<MockApiResponseModel>();
      ConfigureMock_RoleController_Responses();
    }

    public void ConfigureMock_RoleController_Responses()
    {
      
    }
  }
}
