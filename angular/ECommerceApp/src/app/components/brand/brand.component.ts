import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { BrandDto } from 'src/app/models/brandDto';
import { GlobalParams } from 'src/app/models/globalParams';
import { BrandService } from 'src/app/services/brand.service';

@Component({
  selector: 'app-brand',
  templateUrl: './brand.component.html',
  styleUrls: ['./brand.component.scss']
})
export class BrandComponent implements OnInit {
  brands:Array<BrandDto> = [];
  selectedBrand!:BrandDto;
  formulario!: FormGroup;

  constructor(private brandService: BrandService,
    private modalService: NgbModal,
    private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.brandService.getBrands(new GlobalParams()).subscribe(
      data => this.brands = data
    );
    localStorage.setItem('token', 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJCeXJvbiIsImp0aSI6ImUyMzZmNjEyLTIxNDktNDNkMS1iYjY4LTRiMDNiMmM2ZWM4YiIsImlhdCI6IjEvOC8yMDIyIDg6MzQ6MDYiLCJVc2VyTmFtZSI6IkJ5cm9uIiwiZXhwIjoxNjU5MzQzNDQ2LCJpc3MiOiJDdXJzby1OZXQtQmFzaWNvIiwiYXVkIjoiQXBpLUN1cnNvIn0.YNwD1ZJSQs_6C2TIx0LRM2LXRWnAe4CYGy35-I3T5kQ')
  }

  editBrand(code:string, content:any) {
    this.brandService.getBrandById(code).subscribe(
      response => {
        this.selectedBrand = response;
        console.log(this.selectedBrand);
        this.buildForm();
        this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'})
      }
    );
  }

  buildForm() {
    this.formulario= this.formBuilder.group({
      id: [{value: this.selectedBrand.id, disabled: true}, [Validators.required, Validators.maxLength(4)]],
      name: [this.selectedBrand.name, [Validators.required, Validators.pattern(/^[a-zA-Z0-0-_\s.áéíóúÁÉÍÓÚñÑ]+$/)]]
    });
  }

  updateBrand(content:any) {
    if(this.formulario.invalid) {
      return;
    }

    console.log(this.formulario.value);
    console.log(this.formulario.getRawValue());

    this.brandService.updateBrand(this.formulario.getRawValue()).subscribe(
      response => console.log(response)
    );
  }

}
