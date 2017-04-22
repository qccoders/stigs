class Status
{
    date: string;
    text: string;
}

class Notice
{
    id: string;
    xmllang: string;
}

class Reference
{
    dcpublisher: string;
    dcsource: string;
}

class Plaintext
{
    id: string;
    text: string;
}

class Select
{
    idref: string;
    selected: string;
}

class Profile
{
    id: string;
    title: string;
    description: string;
    select: Select[];
}

class Reference2
{
    dctitle: string;
    dcpublisher: string;
    dctype: string;
    dcsubject: string;
    dcidentifier: string;
}

class Fixtext
{
    fixref: string;
    text: string;
}

class Fix
{
    id: string;
}

class Checkcontentref
{
    name: string;
    href: string;
}

class Check
{
    system: string;
    checkcontentref: string;
    checkcontent: string;
}

class Rule
{
    string id;
    string severity;
    string weight;
    string version;
    string title;
    string description;
    reference: Reference2;
    ident: object;
    fixtext: Fixtext;
    fix: Fix;
    check: Check;
}

class Group
{
    id: string;
    title: string;
    description: string;
    Rule: Rule;
}

class Benchmark
{
    xmlnsdsig: string;
    xmlnsxsi: string;
    xmlnscpe: string;
    xmlnsxhtml: string;
    xmlnsdc: string;
    xmlns: string;
    id: string;
    xmllang: string;
    xsischemaLocation: string;
    status: Status;
    title: string;
    description: string;
    notice: Notice;
    reference: Reference;
    plaintext: Plaintext;
    version: string;
    Profile: Profile[];
    Group: Group[];
}

class STIG
{
    Benchmark: Benchmark;
}