import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';



class Operator {
  constructor(public id: number, public value: string, public operationSymbol: string) { }
}

class Calculation {
  constructor(public argumentList: number[], public operationSymbol: string) { }
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  Operators: Operator[] = [
    new Operator(1, "Add","+"),
    new Operator(2, "Substract","-"),
    new Operator(3, "Multiply","*"),
    new Operator(4, "Divide", "/"),
    new Operator(5, "Mod", "%")
  ];
  calculation: Calculation = new Calculation([0,0], "Add");

  result: number = 0;
  resultStyle: string ='black';

  constructor(private http: HttpClient) {

  }

  title = 'CalculatorFrontEnd';

  submit() {
    console.log(this.calculation);
    this.http.post<any>('/api/Calculate', this.calculation, { headers: { 'Content-Type': "application/json" } }).subscribe(data => {
      console.log(data);
      this.result = data;
      console.log("calculate: " + this.result);
      this.resultStyle = this.result % 2 === 0 ? 'green' : 'red';
      console.log(this.resultStyle);
    })

  }
}
