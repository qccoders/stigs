public class Status
{
    public string date { get; set; }
    public string text { get; set; }
}

public class Notice
{
    public string id { get; set; }
    public string xmllang { get; set; }
}

public class Reference
{
    public string dcpublisher { get; set; }
    public string dcsource { get; set; }
}

public class Plaintext
{
    public string id { get; set; }
    public string text { get; set; }
}

public class Select
{
    public string idref { get; set; }
    public string selected { get; set; }
}

public class Profile
{
    public string id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public List<Select> select { get; set; }
}

public class Reference2
{
    public string dctitle { get; set; }
    public string dcpublisher { get; set; }
    public string dctype { get; set; }
    public string dcsubject { get; set; }
    public string dcidentifier { get; set; }
}

public class Fixtext
{
    public string fixref { get; set; }
    public string text { get; set; }
}

public class Fix
{
    public string id { get; set; }
}

public class Checkcontentref
{
    public string name { get; set; }
    public string href { get; set; }
}

public class Check
{
    public string system { get; set; }
    public Checkcontentref checkcontentref { get; set; }
    public string checkcontent { get; set; }
}

public class Rule
{
    public string id { get; set; }
    public string severity { get; set; }
    public string weight { get; set; }
    public string version { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public Reference2 reference { get; set; }
    public object ident { get; set; }
    public Fixtext fixtext { get; set; }
    public Fix fix { get; set; }
    public Check check { get; set; }
}

public class Group
{
    public string id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public Rule Rule { get; set; }
}

public class Benchmark
{
    public string xmlnsdsig { get; set; }
    public string xmlnsxsi { get; set; }
    public string xmlnscpe { get; set; }
    public string xmlnsxhtml { get; set; }
    public string xmlnsdc { get; set; }
    public string xmlns { get; set; }
    public string id { get; set; }
    public string xmllang { get; set; }
    public string xsischemaLocation { get; set; }
    public Status status { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public Notice notice { get; set; }
    public Reference reference { get; set; }
    public Plaintext plaintext { get; set; }
    public string version { get; set; }
    public List<Profile> Profile { get; set; }
    public List<Group> Group { get; set; }
}

public class RootObject
{
    public Benchmark Benchmark { get; set; }
}