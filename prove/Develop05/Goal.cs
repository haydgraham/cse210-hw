class Goal {
    protected string name;
    protected string description;
    protected int points;
    protected Boolean completed;

    //no args constructor
    public Goal(){
        name = "";
        description = "";
        points = 0;
        completed = false;
    }

    //parameterized constructor
    public Goal(string name, string description, int points, Boolean completed){
        this.name = name;
        this.description= description;
        this.points = points;
        this.completed = completed;
    }

    //getters
    public string getName(){
        return name;
    }

    public string getDescrption(){
        return description;
    }

    public int getPoints(){
        return points;
    }

    public Boolean isCompleted(){
        return completed;
    }

    //setters
    public void setName(string name){
        this.name = name;
    }

    public void setDescription(string description){
        this.description = description;
    }

    public void setPoints(int points){
        this.points = points;
    }

    public void setCompleted(Boolean completed){
        this.completed = completed;
    }

    //methods
    public string toString(){
        string completionMark = "";
        if(completed == true){
            completionMark = "[X]";
        }
        else{
            completionMark = "[ ]";
        }
        string objectString = completionMark + " " + name + " (" + description + ") ";
        return objectString;
    }








}