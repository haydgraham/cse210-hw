class Eternal : Goal{

//no unique data members, just take away the ability to complete

//parameterized constructor for eternal goal objects
public Eternal(string name, string description, int points){
    this._completed = false;
    this._name = name;
    this._description = description;
    this._points = points;
}

//converts the eternal goal object to csv format for a text file
public override string ToCsvFormat(){
    _completed = false;
    string goalAsString = $"Eternal,{_completed},{_name},{_description},{_points}";
    return goalAsString;
}

//converts the eternal goal object to the desired program format
public override string ToGoalFormat(){
        string goal = $"[Eternal] {_name} ({_description}) worth:{_points}pts";
        return goal;
    }










}