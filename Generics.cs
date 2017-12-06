// Covariance / contravariance - enable implicit reference conversion for array types
    // Covariance - preserves assignment compatibility 
    
    IEnumerable<string> strings = new List<string>();

    IEnumerable<object> objects = strings;
    
    // Contravariance - reverses it

    static void SetObject(object o) { }

    Action<object> actObject = SetObject;

    Action<string> actString = actObject;


    























// Type inference

// Constraints

// Open and closed types