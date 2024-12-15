//#define SimpleFactory
//#define SimpleFactoryV1
//#define SimpleFactoryV2
#define SimpleFactoryV3

using Microsoft.Extensions.Configuration;
using SimpleFactoryMethod.Creator;
using System;
IConfiguration Configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();
#if SimpleFactory
var app = new CustomApplication(Configuration);
var controller = app.GetController();
controller.WhateverEndPoint();
#endif


#if SimpleFactoryV1
var appv1 = new CustomApplicationV1(Configuration);
var controllerv1 = app.GetController();
controllerv1.WhateverEndPoint();
#endif

#if SimpleFactoryV2
var loggerfactory = new LoggerFactoryV2();
var appv2 = new CustomApplicationV2(Configuration, loggerfactory);

var controllerV2 = appv2.GetController();
controller.WhateverEndPoint();
#endif

#if SimpleFactoryV3
var loggerfactoryV3 = new ConsoleLoggerFactoryV3();
var appv3 = new CustomApplicationV3(Configuration, loggerfactoryV3);
var controllerV3 = appv3.GetController();
controllerV3.WhateverEndPoint();
#endif
