// DateTime - defines a particular date and time
    // had a property called Kind that provides limited information about the time zone to which that date and time belongs to.
    // DateTimeKind
        // DateTimeKind.Local
        // DateTimeKind.Utc
        // DateTimeKind.Unspecified

// The DateTime structure is suitable for applications that do the following:
    // Work with dates only.
    // Work with times only.
    // Work with abstract dates and times.
    // Work with dates and times for which time zone information is missing.
    // Work with UTC dates and times only.

//DateTimeOffset 

    // The DateTimeOffset structure represents a date and time value, together with an offset that indicates how much that value differs from UTC.
    //Thus, the value always unambiguously identifies a single point in time.

    // The DateTimeOffset type includes all of the functionality of the DateTime type along with time zone awareness. This makes it suitable for applications that do the following:

    // Uniquely and unambiguously identify a single point in time.\
    // The DateTimeOffset type can be used to unambiguously define the meaning of "now", to log transaction times, to log the times of system or application events, and to record file creation and modification times.
    // Perform general date and time arithmetic.
    // Preserve multiple related times, as long as those times are stored as two separate values or as two members of a structure.