import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { KeyStoreAppItems } from '../../KeyStoreAppItems';
import { KeyStoreAppService } from '../../key-store-app.service';
import { ActivatedRoute, Router} from '@angular/router';

function findindexByID(jsonnArray: any[], indexToFind: number): number{
  return jsonnArray.findIndex((item) => item.id === indexToFind);
}

@Component({
  selector: 'app-edit',
  standalone: true,
  imports: [FormsModule, MatFormFieldModule, MatSelectModule, MatInputModule, MatButtonModule],
  templateUrl: './edit.component.html',
  styleUrl: './edit.component.css'
})
export class EditComponent implements OnInit {
  KeyStoreService=inject(KeyStoreAppService)
  activatedRoute = inject(ActivatedRoute)
  router = inject(Router);
  editKey: KeyStoreAppItems = {
    id: 0,
    login: "",
    password: "",
    webplatform: "",
    userid: 0,
    userstore: {
      id: 0,
      name: "",
    }
  }
  userstoreObject: any;
  selected: any;
  cID: number = 0;
  ngOnInit()  {
    this.KeyStoreService.getByID(this.activatedRoute.snapshot.params["id"]).subscribe(result => 
      {
        this.editKey = result;
        this.selected = this.editKey.userid;
      });
      this.KeyStoreService.getAllUsers().subscribe((result) => {
        this.userstoreObject = result;
      });
  }
  toHome() {
    this.router.navigateByUrl("home")
  }
  edit() {
    this.editKey.userid = this.cID;
    this.editKey.userstore = this.userstoreObject[findindexByID(this.userstoreObject, this.cID)];
    this.KeyStoreService.editKeyStoreitems(this.editKey).subscribe(res => {
      alert("Changes has been updated")
      this.router.navigateByUrl("home")
    })
  }
  
  

}
