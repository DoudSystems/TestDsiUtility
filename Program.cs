Console.WriteLine("Log2Text");

using (Dsi.Utility.Log2Text logger = new Dsi.Utility.Log2Text(@"C:\Users\gpdou\Desktop\log2text.log")) {

    logger.Log("Testing Log2Text");
    logger.LogDebug("Test line 1");
    logger.LogError("Test line 2");
    logger.LogWarn("Test line 3");
    logger.Log("Test line 4");

}
//l2t.Dispose();