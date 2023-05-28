import { playerRefs } from "../main";

export function setMemberData(data) {
    playerRefs.value = data;
    console.log(playerRefs.value);

}

export function getMemberData() {
    return playerRefs;
}

