
using SimpleFactoryMethod.Creator.Loggers;

class Controller
{
    private readonly ILogger logger;

    public Controller(ILogger logger)
    {
        this.logger = logger;
    }
    public void WhateverEndPoint()
    {   
        logger.Log("im doing what ever");
    }
}


