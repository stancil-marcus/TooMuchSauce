class Student extends Account{

    private student_id;
    private school;
    private classcode;
    constructor(firstname,lastname,username,password,student_id,school,classcode){
        super(firstname,lastname,username,password);
        this.student_id = student_id;
        this.classcode = classcode;
        this.school = school;
    }
    get firstName(){
        super
    }
}