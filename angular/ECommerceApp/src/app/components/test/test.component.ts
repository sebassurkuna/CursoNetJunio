import { HttpClient } from '@angular/common/http';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.scss']
})
export class TestComponent implements OnInit {
  @Input() nombre:string= "Nombre";
  @Input() apellido:string= "";
  @Output() saludar: EventEmitter<string> = new EventEmitter();

  numeros:any= [];

  brands:any[]= []

  listaNombres:Array<string> = [];
  inputName:string = '';

  constructor(private http: HttpClient) { 
    //this.nombre= 'David';
    //this.numeros= [1,2,3];
  }


  onNombreClic() {
    this.saludar.emit("Estamos viendo el binding de eventos");
  }

  agregarNombre() {
    this.listaNombres.push(this.inputName);
    this.inputName="";
    console.log(this.listaNombres);
  }

  // actualizarInputName(event:any) {
  //   this.inputName= event.target.value;
  //   console.log(this.inputName);
  // }

  ngOnInit(): void {
    this.http.get('https://localhost:44316/api/Brand')
      .subscribe((response:any) => {
        console.log(response);
        this.brands = response
    });

  } 
}
