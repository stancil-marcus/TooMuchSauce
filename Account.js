/**
 * Created by edwinmwaniki on 10/16/16.
 */
class Account {
    private firstname;
    private lastname;
    private username;
    private password;
    private loginstatus;
    constructor(firstname,lastname,username,password){
        this.firstname = firstname;
        this.lastname = lastname;
        this.username = username;
        this.password = password;
    }

    get Firstname(){
        return this.firstname;
    }
    get LastName(){
        return this.lastname;
    }
    get UserName(){
        return this.username;
    }
    get PassWord(){
        return this.password;
    }
    get LoginStatus(){
        return this.loginstatus
    }

}