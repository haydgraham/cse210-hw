class Checklist : Goal{
    //unique members: 
    private int _times;
    private int _bonus;

    //parameterized checklist goal constructor
    public Checklist(Boolean completed, string name, string description, int points, int times, int bonus){
        this._completed = completed;
        this._name = name;
        this._description = description;
        this._points = points;
        this._times = times;
        this._bonus = bonus;
    }

    //converts the checklist goal to csv
   public override string ToCsvFormat(){
        string goalAsString = $"Checklist,{_completed},{_name},{_description},{_points},{_times},{_bonus}";
        return goalAsString;
    }

    //converts the checklist object to the program format
    public override string ToGoalFormat(){
        string goal = $"{IsCompleted(_completed)} {_name} ({_description}) worth:{_points}pts -- {_times} more until bonus:{_bonus}pts --";
        return goal;
    }








}