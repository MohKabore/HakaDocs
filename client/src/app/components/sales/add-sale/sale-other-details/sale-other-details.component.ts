import { Component, Input, OnInit } from '@angular/core';
import { FormGroup, Validators } from '@angular/forms';
import { OrdersService } from 'src/app/_services/orders.service';

@Component({
  selector: 'app-sale-other-details',
  templateUrl: './sale-other-details.component.html',
  styleUrls: ['./sale-other-details.component.scss']
})
export class SaleOtherDetailsComponent implements OnInit {
  @Input() saleDetailsForm: FormGroup;
  invoiceDeliveryMethods =[
    {value:1, text : 'par email'},
    {value:2, text : 'par whatsapp'},
    {value:3, text : 'par sms'}
  ];

  constructor(private ordersService: OrdersService) {
  }


  ngOnInit(): void {
    const details = this.ordersService.getBasketDetails();
    if (!!details) {
      console.log(details);
      this.saleDetailsForm.setValue(details);
    }
    this.saleDetailsForm.controls['paimentType'].valueChanges.subscribe(value => {
      if (!!value && +value === 2)
        this.saleDetailsForm.get('amountPaid').addValidators(Validators.required);
      else
        this.saleDetailsForm.get('amountPaid').clearValidators();
      
      
        this.saleDetailsForm.get('amountPaid').updateValueAndValidity();

      
    });

    this.saleDetailsForm.valueChanges.subscribe(selectedValue => {
      this.ordersService.setBasketDetails(selectedValue);
    })
  }

  onCheckboxChange(event) {
    let selectedValues:[] = this.saleDetailsForm.value.invoiceSendingType ;
    const value = event.target.value;
    if (!!selectedValues) {
      const idx = selectedValues.findIndex(a => a ===value);
      if(idx===-1) this.saleDetailsForm.get('invoiceSendingType').patchValue([...selectedValues,value]);
      else {
        this.saleDetailsForm.get('invoiceSendingType').patchValue(selectedValues.filter(a => a!==value));
      }
    } else 
    this.saleDetailsForm.get('invoiceSendingType').patchValue([value]);
  }



}
