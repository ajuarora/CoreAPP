import { Photo } from "./Photo";
export interface User {
  id: number;
  username: string;
  knownAs: string;
  created: Date;
  lastActive: Date;
  photoUrl: string;
  country: string;
  interests?: string;
  introduction?: string;
  photos?: Photo[];
}
