namespace Singleton
{
  public sealed class MySingleton
  {
    private static readonly object lockObject = new();
    private static volatile MySingleton? UniqueInstance;
    private MySingleton()
    {

    }

    public static MySingleton GetInstance()
    {
      if (UniqueInstance == null)
      {
        lock (lockObject)
        {
          if (UniqueInstance == null)
          {
            UniqueInstance = new MySingleton();
          }
        }
      }
      return UniqueInstance;
    }

    public void SayHi()
    {
      Console.WriteLine("hello");
    }
  }
}
