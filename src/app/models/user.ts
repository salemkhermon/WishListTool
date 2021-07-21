export class User{
    email!: string;
    password!: string;
    isAdmin!: boolean;
    constructor(email :string, password : string ){
        this.email = email;
        this.password = password;
    }
}