class Simple : Goal {

//parameterized constructor for simple goal objects
public Simple(Boolean completed, string name, string description, int points){
    this._completed = completed;
    this._name = name;
    this._description = description;
    this._points = points;
}

//converts the goal object to csv format for text file
 public override string ToCsvFormat(){
        string goalAsString = $"Simple,{_completed},{_name},{_description},{_points}";
        return goalAsString;
    }

//converts the goal object to the desired simple goal format
public override string ToGoalFormat(){
        string goal = $"{IsCompleted(_completed)} {_name} ({_description}) worth:{_points}pts";
        return goal;
    }


}