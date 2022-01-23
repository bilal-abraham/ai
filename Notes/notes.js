class Student {
    constructor(studentId) {
        if (studentId < 0) {
            this.studentId = -1
        }else{
            this.studentId = studentID;
        }
        this.grades = []

        calcAverage(){
            for (let i = 0; i < grades.length; i++) {
                let sum = 0
                grades[i] + sum = sum
                if (i > grades.length){
                    sum/grades.length
                }
            }

            if (grades.length < 0){
                grades.push = (100)
            }

        }

        addGrade(grade){
            if (grade > -1 && grade < 101){
                grades.push(grade)
                return true;
            }
            else{    
                return false;
            }
        }

    }
}
