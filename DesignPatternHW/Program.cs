// Singleton Pattern
// Creational
/*  Singleton Patterns, in a real project, are usually used to create a private constructor,
     a private static variable or static method.*/ 


public sealed class singleton
{
    private static singleton instance = null;

    private singleton()
    {

    }

    public static singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new singleton();
            }
            return instance;
        }
    }
}
