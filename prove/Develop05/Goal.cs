class Goal {
    protected string _name;
    protected string _description;
    protected int _points;
    protected Boolean _completed;

    //no args constructor
    public Goal(){
        _name = "";
        _description = "";
        _points = 0;
        _completed = false;
    }

    //parameterized constructor
    public Goal(string name, string description, int points, Boolean completed){
        this._name = name;
        this._description= description;
        this._points = points;
        this._completed = completed;
    }

    //getters
    public string GetName(){
        return _name;
    }

    public string GetDescrption(){
        return _description;
    }

    public int GetPoints(){
        return _points;
    }

    //setters
    public void GetName(string name){
        this._name = name;
    }

    public void SetDescription(string description){
        this._description = description;
    }

    public void SetPoints(int points){
        this._points = points;
    }

    public void SetCompleted(Boolean completed){
        this._completed = completed;
    }


    //takes the goal attributes and converts them to a csv formatted string to be added to a text file
    public virtual string ToCsvFormat(){
        string goalAsCsv = $"Goal:{_completed},{_name},{_description},{_points}";
        return goalAsCsv;
    }

    public virtual string ToGoalFormat(){
        string goal = $"{IsCompleted(_completed)} {_name} ({_description}) {_points}";
        return goal;
    }

    //reads the csv string into the desired program format
    public static string CsvToGoalFormat(string csvString){
        string[] parts = csvString.Split(",");
        string goalFormatString = "";
        foreach(string part in parts){
            goalFormatString+=part + " ";
        }
        return goalFormatString;

    }



      public static string MarkComplete(string goal){
        string[] parts = goal.Split(" ");
        if(parts[0] != "[Eternal]"){
            parts[0] = "[X]";
        }
        string goalFormatString = "";
        foreach(string part in parts){
            goalFormatString+=part + " ";
        }
        return goalFormatString;

    }

    //returns an x if the completed class member == true
    public static string IsCompleted(Boolean completed){
        string completionMark = "";
        if(completed == true){
            completionMark = "[X]";
        }
        else{
            completionMark = "[]";
        }
        return completionMark;
    }









}