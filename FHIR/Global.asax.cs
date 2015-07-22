using FHIR;
using FHIR.Services;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Caching;
using System;
using System.Collections.Generic;
using System.Web;

namespace PatientWebService
{
    public class Global : System.Web.HttpApplication
    {
        public class AppHost : AppHostBase
        {
            public AppHost() : base("FHIR Web Services", typeof(PatientService).Assembly) { }

            public override void Configure(Funq.Container container)
            {
                container.RegisterAutoWired<DataRepository>();

                // Using the CorsFeature plugin
                //Plugins.Add(new CorsFeature());
                /* Default values:
                CorsFeature(allowedOrigins: "*",
                    allowedMethods: "GET, POST, PUT, DELETE, OPTIONS",
                    allowedHeaders: "Content-Type",
                    allowCredentials: false);
                */
                Plugins.Add(new CorsFeature(
                    allowOriginWhitelist: new[] { "http://localhost:36085", "http://localhost", "http://hwl59427d", "http://edwaitingtimes-test", "http://edwaitingtimes" },
                    allowedHeaders: "Content-Type",
                    allowCredentials: true
                    ));

                //// Manually enabling CORS
                //base.SetConfig(new HostConfig
                //{
                //    GlobalResponseHeaders = {
                //        { "Access-Control-Allow-Origin", "http://localhost:36085" },
                //        { "Access-Control-Allow-Methods", "GET, POST, OPTIONS" },
                //        { "Access-Control-Allow-Headers", "accept, content-type, authorization, origin" },
                //        { "Access-Control-Allow-Credentials", "true" },
                //    }
                //});

                // Globally enable CORS for all OPTION requests
                this.PreRequestFilters.Add((httpReq, httpRes) =>
                {
                    //Handles Request and closes Responses after emitting global HTTP Headers
                    if (httpReq.Verb == "OPTIONS")
                        httpRes.EndRequest();
                });

                //Set JSON web services to return idiomatic JSON camelCase properties   
                ServiceStack.Text.JsConfig.EmitCamelCaseNames = true;
             }
        } 

        protected void Application_Start(object sender, EventArgs e) 
        {
            new AppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}