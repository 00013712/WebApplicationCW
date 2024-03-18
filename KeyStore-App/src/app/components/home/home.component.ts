import { Component, Input, inject } from '@angular/core';
import {MatTableModule} from '@angular/material/table';
import { KeyStoreAppItems } from '../../KeyStoreAppItems';
import { MatButtonModule } from '@angular/material/button';
import { KeyStoreAppService } from '../../key-store-app.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [MatTableModule, MatButtonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
})
export class HomeComponent {
  router= inject(Router)
  KeyStoreService=inject(KeyStoreAppService)
  itemsList: KeyStoreAppItems[]=[
    {
      "id": 1,
      "login": "Complete Project",
      "password": "Finish the coding project by the deadline.",
      "webplatform": "Wiut Intranet",
      "userid": 1,
      "userstore": {
        "id": 3,
        "name": "Work"
      }
    },
    {
      "id": 2,
      "login": "Buy Groceries",
      "password": "Purchase items for the week.",
      "webplatform": "Wiut Intranet",
      "userid": 1,
      "userstore": {
        "id": 1,
        "name": "Personal"
      }
    },
    {
      "id": 3,
      "login": "Read Book",
      "password": "Read the latest novel.",
      "webplatform": "Wiut Intranet",
      "userid": 2,
      "userstore": {
        "id": 2,
        "name": "Leisure"
      }
    },
    {
      "id": 4,
      "login": "Plan Vacation",
      "password": "Research and plan a vacation destination.",
      "webplatform": "Wiut Intranet",
      "userid": 2,
      "userstore": {
        "id": 2,
        "name": "Leisure"
      }
    },
    {
      "id": 5,
      "login": "Exercise",
      "password": "Go for a jog or hit the gym.",
      "webplatform": "Wiut Intranet",
      "userid": 1,
      "userstore": {
        "id": 1,
        "name": "Personal"
      }
    },
    {
      "id": 6,
      "login": "Write Blog Post",
      "password": "Create a new blog post on a relevant topic.",
      "webplatform": "Wiut Intranet",
      "userid": 3,
      "userstore": {
        "id": 3,
        "name": "Work"
      }
    },
    {
      "id": 7,
      "login": "Attend Meeting",
      "password": "Participate in the weekly team meeting.",
      "webplatform": "Wiut Intranet",
      "userid": 3,
      "userstore": {
        "id": 3,
        "name": "Work"
      }
    },
    {
      "id": 8,
      "login": "Cook Dinner",
      "password": "Prepare a delicious dinner for the family.",
      "webplatform": "Wiut Intranet",
      "userid": 1,
      "userstore": {
        "id": 1,
        "name": "Personal"
      }
    },
    {
      "id": 9,
      "login": "Learn New Skill",
      "password": "Start learning a new programming language.",
      "webplatform": "Wiut Intranet",
      "userid": 3,
      "userstore": {
        "id": 3,
        "name": "Work"
      }
    },
    {
      "id": 10,
      "login": "Watch Movie",
      "password": "Catch up on the latest blockbuster.",
      "webplatform": "Wiut Intranet",
      "userid": 2,
      "userstore": {
        "id": 2,
        "name": "Leisure"
      }
    },
    {
      "id": 11,
      "login": "Organize Workspace",
      "password": "Declutter and organize the home office.",
      "webplatform": "Wiut Intranet",
      "userid": 3,
      "userstore": {
        "id": 3,
        "name": "Work"
      }
    },
    {
      "id": 12,
      "login": "Attend Webinar",
      "password": "Participate in a webinar on emerging technologies.",
      "webplatform": "Wiut Intranet",
      "userid": 3,
      "userstore": {
        "id": 3,
        "name": "Work"
      }
    },
    {
      "id": 13,
      "login": "Practice Instrument",
      "password": "Spend time practicing the guitar.",
      "webplatform": "Wiut Intranet",
      "userid": 2,
      "userstore": {
        "id": 2,
        "name": "Leisure"
      }
    },
    {
      "id": 14,
      "login": "Update Resume",
      "password": "Revise and update the professional resume.",
      "webplatform": "Wiut Intranet",
      "userid": 3,
      "userstore": {
        "id": 3,
        "name": "Work"
      }
    },
    {
      "id": 15,
      "login": "Explore Local Park",
      "password": "Take a leisurely walk in the nearby park.",
      "webplatform": "Wiut Intranet",
      "userid": 2,
      "userstore": {
        "id": 2,
        "name": "Leisure"
      }
    },
    {
      "id": 16,
      "login": "Complete Online Course",
      "password": "Finish the online course on data science.",
      "webplatform": "Wiut Intranet",
      "userid": 3,
      "userstore": {
        "id": 3,
        "name": "Work"
      }
    },
    {
      "id": 17,
      "login": "Volunteer for Charity",
      "password": "Contribute time to a local charity or community service.",
      "webplatform": "Wiut Intranet",
      "userid": 1,
      "userstore": {
        "id": 1,
        "name": "Personal"
      }
    },
    {
      "id": 18,
      "login": "Visit Art Gallery",
      "password": "Explore the latest art exhibitions in the city.",
      "webplatform": "Wiut Intranet",
      "userid": 2,
      "userstore": {
        "id": 2,
        "name": "Leisure"
      }
    },
    {
      "id": 19,
      "login": "Review Budget",
      "password": "Assess and review monthly budget and expenses.",
      "webplatform": "Wiut Intranet",
      "userid": 1,
      "userstore": {
        "id": 1,
        "name": "Personal"
      }
    },
    {
      "id": 20,
      "login": "Practice Meditation",
      "password": "Engage in daily meditation for mindfulness.",
      "webplatform": "Wiut Intranet",
      "userid": 1,
      "userstore": {
        "id": 1,
        "name": "Personal"
      }
    }
  ]
  ngOnInit(){
    this.KeyStoreService.getAllKeyStoreItems().subscribe((result)=>{
      this.itemsList=result
    });
  }
  displayedColumns: string[] = ['ID', 'Login', 'Password', 'WebPlatform', 'Name', 'Actions'];

  DeleteClicked(itemid: number) {     
    console.log(itemid, "delete");
    this.router.navigateByUrl("/delete/"+itemid);
  };
  DetailsClicked(itemid: number) {
    console.log(itemid, "details");
    this.router.navigateByUrl("/details/"+itemid);
  };
  EditClicked(itemid: number) {
    console.log(itemid, "edit");
    this.router.navigateByUrl("/edit/"+itemid);
  }
}
