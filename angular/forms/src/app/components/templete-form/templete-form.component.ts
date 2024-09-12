import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { BrandService } from 'src/app/services/brand.service';

@Component({
  selector: 'app-templete-form',
  templateUrl: './templete-form.component.html',
  styleUrls: ['./templete-form.component.scss']
})
export class TempleteFormComponent implements OnInit {
  brand:{code:string,description:string}={code:'', description:''};
  submitted:boolean= false;

  constructor(private brandService:BrandService) { }

  ngOnInit(): void {
  }

  onSubmit(formulario: NgForm) {
    console.log(formulario);

    if(formulario.form.invalid) {
      this.submitted = true;
      console.log('el formulario es invalido');
      
    } else {
      console.log('Creando marca');
      this.brandService.createBrand(formulario.value).subscribe(data => {
        console.log(data);
      });
    }
    
  }

}
