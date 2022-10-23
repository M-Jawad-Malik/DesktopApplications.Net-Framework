﻿var Currentuid;
var chatKey = '';

var ToId = '';
document.addEventListener('keydown', function (key) {
    if (key.which === 13) {
        sendMessage();
    }
});

var imgurl = "https://firebasestorage.googleapis.com/v0/b/deservico-c1eab.appspot.com/o/images%2Favatar.png?alt=media&token=0da654c2-4dc5-44f1-be41-a5bd388726c0";
function showEmojis() {
    if (document.getElementById('emojiContainer').hasAttribute('style')) {
        document.getElementById('emojiContainer').removeAttribute('style');
    } else {
        document.getElementById('emojiContainer').setAttribute('style', 'display:none');
    }
   
}
function loadAllEmoji() {
    var emoji = '';
    for (var i = 128512; i <= 128591; i++) {
        emoji += `<a href="#" style="font-size:30px" onclick="getEmoji(this)"> &#${i};</a>`;
    }   
    document.getElementById('Smiley').innerHTML= emoji;
}

function getEmoji(control) {
    document.getElementById('txtMessage').value += control.innerHTML;
}

function showLoginBox() {
    openLoginModal();
}
function sendMessage() {
    chatMessage = {
        id: '', text:'', fromId: '', toId: '', timeStamp: Math.floor(new Date().getTime() / 1000)
    };
    var a = document.getElementById('txtMessage');
    if (a.value != '') {
    chatMessage.fromId = firebase.auth().currentUser.uid;
    chatMessage.toId = ToId;
    chatMessage.text = a.value;
    var ref = firebase.database().ref('/user-messages/' + chatMessage.fromId.toString() + '/' + chatMessage.toId.toString()).push();
    var toref = firebase.database().ref('/user-messages/' + chatMessage.toId.toString() + '/' + chatMessage.fromId.toString()).push();
    chatMessage.id = ref.getKey();
    ref.set(
        {
            fromId: chatMessage.fromId,
            id: chatMessage.id,
            text: chatMessage.text,
            timeStamp: chatMessage.timeStamp,
            toId: chatMessage.toId
        });
    toref.set(
        {
            fromId: chatMessage.fromId,
            id: chatMessage.id,
            text: chatMessage.text,
            timeStamp: chatMessage.timeStamp,
            toId: chatMessage.toId
        });
    var latestMessageFromRef = firebase.database().ref('/latest-messages/' + chatMessage.fromId.toString() + '/' + chatMessage.toId.toString());
    var latestMessageToRef = firebase.database().ref('/latest-messages/' + chatMessage.toId.toString() + '/' + chatMessage.fromId.toString());
    latestMessageFromRef.set(
        {
            fromId: chatMessage.fromId,
            id: chatMessage.id,
            text: chatMessage.text,
            timeStamp: chatMessage.timeStamp,
            toId: chatMessage.toId
        });
    latestMessageToRef.set(
        {
            fromId: chatMessage.fromId,
            id: chatMessage.id,
            text: chatMessage.text,
            timeStamp: chatMessage.timeStamp,
            toId: chatMessage.toId
        });
    var objToday = new Date(),
        curHour = objToday.getHours() > 12 ? objToday.getHours() - 12 : (objToday.getHours() < 10 ? "0" + objToday.getHours() : objToday.getHours()),
        curMinute = objToday.getMinutes() < 10 ? "0" + objToday.getMinutes() : objToday.getMinutes();
    

    var message = `<div class="row justify-content-end">
                       <div class="col-7 col-sm-7 col-md-7">
                           <p class="sent float-right"  >
                             ${a.value}
                               <span class="time float-right">${curHour + ":" + curMinute + " PM"}</span>
                           </p>
                       </div>
                       <div class="col-2 col-sm-1 col-md-1">
                           <img src="${firebase.auth().currentUser.photoURL}" class="chat-pic rounded-circle"  />
                       </div>
                   </div>`;

    document.getElementById("txtMessage").value = '';
        document.getElementById("txtmessage").focus();
    }
}
function startChat(friendKey, friendName, friendImg, currentUserImgURL) {
    ToId = friendKey
    document.getElementById('chatPanel').removeAttribute("style");
    document.getElementById('divStart').setAttribute("style", "display:none");
    hideChatList();
    //display friend name and photo
    document.getElementById('divChatName').innerHTML = friendName;
    document.getElementById('divChatImg').src = friendImg;
   
    /*   });*/
    LoadChatMessages(friendKey, friendImg, currentUserImgURL);
}
function loadChatList() {
    var photourl;
    if (firebase.auth().currentUser.photoURL != null) {
        photourl = firebase.auth().currentUser.photoURL;
    } else {
        var db = firebase.database().ref('/msgUsersInfo/' + firebase.auth().currentUser.uid.toString())
        db.on('value', function (us) {
            if (us.hasChildren()) {
                var s = us.val();
                if (s.profileImageUrl == "") {
                    photourl = imgurl;
                } else {
                    photourl = s.profileImageUrl;
                }
            }
        })
    }

    document.getElementById("Message").innerHTML = '';
    var fromId = firebase.auth().currentUser.uid;
    var db = firebase.database().ref('latest-messages/' + fromId.toString())
    db.on('value', function (lists) {
        document.getElementById('lstChat').innerHTML = ` <li class="list-group-item" style="background-color:#f8f8f8;">
                            <input type="text" placeholder="Search or new chat" class="form-control form-rounded" />
                        </li>`;
        lists.forEach(function (data) {
            var user = data.val();
            var chatPartnerId = ''
            if (user.fromId == firebase.auth().currentUser.uid) {
                chatPartnerId = user.toId

            } else {

                chatPartnerId = user.fromId
            }
            var userdb = firebase.database().ref('/msgUsersInfo/')
            var urlimg;
            userdb.on('value', function (userlists) {
                userlists.forEach(function (userdata) {
                    var usr = userdata.val();
                    if (usr.profileImageUrl == "") {
                        urlimg ="https://firebasestorage.googleapis.com/v0/b/deservico-c1eab.appspot.com/o/images%2Favatar.png?alt=media&token=0da654c2-4dc5-44f1-be41-a5bd388726c0";
                       
                    } else {
                        urlimg = usr.profileImageUrl;
                    }
                    if (chatPartnerId == usr.uid) {
                        document.getElementById('lstChat').innerHTML += `<li class="list-group-item list-group-item-action"  onclick="startChat('${chatPartnerId}','${usr.username}','${urlimg}','${photourl}')">
                            <div class="row">
                                <div class="col-md-2">
                                    <img src="${urlimg}" class="rounded-circle friend-pic" />
                                </div>
                                <div class="col-md-10" style="cursor:pointer;">
                                    <div class="name">
                                        ${usr.username}
                                    </div>
                                    <div class="ltstmsg">
                                    ${user.text}
                                    </div>
                                </div>
                            </div>
                        </li>`;

                    }
                })
            })

        })
    })


}
function LoadChatMessages(toID, friendImg, currentUserImgURL) {
  
    var messageDisplay = ''
    var fromId = firebase.auth().currentUser.uid;
    var db = firebase.database().ref('/user-messages/' + fromId.toString() + '/' + toID.toString());
    db.on('value', function (chat) {
        document.getElementById("Message").innerHTML = '';
        chat.forEach(function (data) {
            var message = data.val();
            var dateTime = timeConverter(message.timeStamp);
            var msg
            if (message.text.indexOf("image/") != -1) {
                msg = `<img src="${message.text}" style="width:350px;height:300px;" class="img-fluid"/>`
            }
            else if (message.text.indexOf("audio/webm") !== -1) {
                msg = `<audio src="${message.text}" controls></audio>`
            }
            else {
                msg = message.text;
            }
            if (message.fromId == firebase.auth().currentUser.uid) {
                messageDisplay = `<div class="row justify-content-end">
                       <div class="col-7 col-sm-7 col-md-7">
                           <p class="sent float-right"  >
                             ${msg}
                               <span class="time float-right">${dateTime}</span>
                           </p>
                       </div>
                       <div class="col-2 col-sm-1 col-md-1">
                           <img src="${currentUserImgURL}" class="chat-pic rounded-circle"  />
                       </div>
                   </div>`;

            } else {

                messageDisplay = `<div class="row">
                            <div class="col-2 col-sm-1 col-md-1">
                                <img src="${friendImg}" class="chat-pic rounded-circle" />
                            </div>
                            <div class="col-7 col-sm-7 col-md-7">
                                <p class="recieve">
                                    ${msg}
                                    <span class="time float-right">${dateTime}</span>
                                </p>
                            </div>
                           
                        </div>`;
            }
           
            document.getElementById("Message").innerHTML += messageDisplay;
            document.getElementById("Message").scrollTo(0, document.getElementById("Message").scrollHeight);

        })
    })
}
function populateFriendList() {
    document.getElementById("lstFriend").innerHTML = `<div class="text-center">
<span class="spinner-border text-primary mt-5" style="width:7rem;height:7rem;"></span>    
</div>`
    var db = firebase.database().ref('/msgUsersInfo/')
    var lst;
    db.on('value', function (users) {
        if (users.hasChildren()) {

            lst = `<li class="list-group-item" style="background-color:#f8f8f8;">
                            <input type="text" placeholder="Search or new chat" class="form-control form-rounded" />
                        </li>`;

        }
        var myimgUrl;
        if (firebase.auth().currentUser.photoURL!=null) {
            myimgUrl = firebase.auth().currentUser.photoURL;
        
        } else {

            var db = firebase.database().ref('/msgUsersInfo/' + firebase.auth().currentUser.uid.toString())
            db.on('value', function (us) {
                if (us.hasChildren()) {
                    var s = us.val();
                    if (s.profileImageUrl == "") {
                        myimgUrl = imgurl;
                    } else {
                    myimgUrl= s.profileImageUrl;
                    }
                }

            })
        }
        var urlimg;
        Currentuid = firebase.auth().currentUser.uid;
        users.forEach(function (data) {
            var user = data.val();
            if (user.profileImageUrl == "") {
                urlimg = "https://firebasestorage.googleapis.com/v0/b/deservico-c1eab.appspot.com/o/images%2Favatar.png?alt=media&token=0da654c2-4dc5-44f1-be41-a5bd388726c0";

            } else {
                urlimg = user.profileImageUrl;
            }
            if (user.uid != Currentuid) {

                lst += `<li class="list-group-item list-group-item-action" data-dismiss="modal" onclick="startChat('${user.uid}','${user.username}','${urlimg}','${myimgUrl}')">
                            <div class="row">
                                <div class="col-md-2">
                                    <img src="${urlimg}" class="rounded-circle friend-pic" />
                                </div>
                                <div class="col-md-10" style="cursor:pointer;">
                                    <div class="name">
                                        ${user.username}
                                    </div>
                                    
                                </div>
                            </div>

                        </li>`;


            } 
        });
        document.getElementById("lstFriend").innerHTML = lst;
    });


}
function timeConverter(UNIX_timestamp) {
    var a = new Date(UNIX_timestamp * 1000);
    var months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
    var year = a.getFullYear();
    var month = months[a.getMonth()];
    var date = a.getDate();
    var hour = a.getHours();
    var min = a.getMinutes();
    var sec = a.getSeconds();
    var time = date + ' ' + month + ' ' + year + ' ' + hour + ':' + min + ':' + sec;
    return time;
}
function chat() {
    var fruits = ["Banana", "Orange", "Apple", "Mango", "Kiwi"]
}
function showChatList() {
    document.getElementById("box1").classList.remove("d-none", "d-md-block");
    document.getElementById('box2').classList.add('d-none');
}
function hideChatList() {
    document.getElementById("box2").classList.remove("d-none", "d-md-block");
    document.getElementById('box1').classList.add('d-none');
}

function onStateChange(user) {
    if (user) {
        var userProfile = { uid: '', email: '', username: '', profileImageUrl: '' }
        userProfile.uid = user.uid;
        uid = user.uid;
        if (firebase.auth().currentUser.photoURL != null) {
            
            userProfile.email = firebase.auth().currentUser.email;
            userProfile.name = firebase.auth().currentUser.displayName;
            userProfile.profileImageUrl = firebase.auth().currentUser.photoURL;
            firebase.database().ref('msgUsersInfo/' + userProfile.uid.toString()).set(
                {
                    email: userProfile.email,
                    profileImageUrl: userProfile.profileImageUrl,
                    uid: userProfile.uid,
                    username: userProfile.name
                });
            var a = firebase.auth().displayName
            document.getElementById('profile-img').src = firebase.auth().currentUser.photoURL;
            document.getElementById('profile-img').title = firebase.auth().currentUser.displayName;
        } else {
            
            var db = firebase.database().ref('/msgUsersInfo/' + firebase.auth().currentUser.uid.toString())
            db.on('value', function (us) {
                if (us.hasChildren()) {
                    var s = us.val();
                    if (s.profileImageUrl == "") {
                        document.getElementById('profile-img').src = imgurl;
                    } else {
                        document.getElementById('profile-img').src = s.profileImageUrl;
                    }
                 
                    document.getElementById('profile-img').title = s.username;

                }

            })
                }
        document.getElementById('signInLink').style = 'display:none;';
        document.getElementById('signOutLink').style = '';
        document.getElementById('lnkNewChat').classList.remove('disable');
        loadChatList();
    } else {
        openLoginModal();
        document.getElementById('profile-img').src = 'imgs/pp.png';
        document.getElementById('profile-img').title = '';
        document.getElementById('signInLink').style = '';
        document.getElementById('signOutLink').style = 'display:none;';
        document.getElementById('lnkNewChat').classList.add('disable');
    }
}
function onFirebaseStateChange() {

    firebase.auth().onAuthStateChanged(onStateChange)

}
function signIn() {
    var provider = new firebase.auth.GoogleAuthProvider;
    firebase.auth().signInWithPopup(provider);
    emailpasslogin = false;
    $('#loginModal').modal('hide');
}
function signOut() {
    firebase.auth().signOut();
    document.getElementById('box2').classList.add('d-none');
    document.getElementById("box1").classList.remove("d-none");
    document.getElementById("box1").classList.add("d-md-block");
    openLoginModal();
    document.getElementById('lstChat').innerHTML = "";
}
function callback(error) {
    if (error) {
        alert(error)
    } else {
        document.getElementById('profile-img').src = firebase.auth().currentUser.photoURL;
        document.getElementById('profile-img').title = firebase.auth().currentUser.displayName;

        document.getElementById('signInLink').style = 'display:none;';
        document.getElementById('signOutLink').style = '';
        document.getElementById('lnkNewChat').style = 'display:none;';
    }
}

function chooseImage() {
    document.getElementById('imageFile').click();
}
function sendImage() {
    var file = document.getElementById('imageFile').files[0];
    if (!file.type.match("image.*")) {
        alert('Select Image only')
    } else {
        var reader = new FileReader();
        reader.addEventListener('load', function () {
            chatMessage = {
                id: '', text: '', fromId: '', toId: '', timeStamp: Math.floor(new Date().getTime() / 1000)
            };
           
                chatMessage.fromId = firebase.auth().currentUser.uid;
            chatMessage.toId = ToId;
            chatMessage.text = reader.result;
                var ref = firebase.database().ref('/user-messages/' + chatMessage.fromId.toString() + '/' + chatMessage.toId.toString()).push();
                var toref = firebase.database().ref('/user-messages/' + chatMessage.toId.toString() + '/' + chatMessage.fromId.toString()).push();

                chatMessage.id = ref.getKey();
                ref.set(
                    {
                        fromId: chatMessage.fromId,
                        id: chatMessage.id,
                        text: chatMessage.text,
                        timeStamp: chatMessage.timeStamp,
                        toId: chatMessage.toId
                    });
                toref.set(
                    {
                        fromId: chatMessage.fromId,
                        id: chatMessage.id,
                        text: chatMessage.text,
                        timeStamp: chatMessage.timeStamp,
                        toId: chatMessage.toId
                    });
                document.getElementById("txtMessage").value = '';
                document.getElementById("txtmessage").focus();
            
        }, false)
        if (file) {
            reader.readAsDataURL(file);
        }
    }
}

function ChangeSendIcon(control) {
    if (control.value != '') {
        document.getElementById('send').removeAttribute('style');
        document.getElementById('audio').setAttribute('style', 'display:none');
    } else {
        document.getElementById('audio').removeAttribute('style');
        document.getElementById('send').setAttribute('style', 'display:none');
    }
}



let chunks = [];
let recorder;
var timeOut;
function record(control) {
    ////Audio Record
    let device = navigator.mediaDevices.getUserMedia({ audio: true })
    device.then(stream => {
       
        if (recorder === undefined) {
           
           recorder = new MediaRecorder(stream);
            recorder.ondataavailable = e => {
                chunks.push(e.data);
                if (recorder.state == 'inactive') {
                    let blob = new Blob(chunks, { type: 'audio/webm'});
                    //document.getElementById('audio').src = URL.createObjectURL(blob);
                    var reader = new FileReader();
                    reader.addEventListener('load', function () {
                        chatMessage = {
                            id: '', text: '', fromId: '', toId: '', timeStamp: Math.floor(new Date().getTime() / 1000)
                        };

                        chatMessage.fromId = firebase.auth().currentUser.uid;
                        chatMessage.toId = ToId;
                        chatMessage.text = reader.result;
                        var ref = firebase.database().ref('/user-messages/' + chatMessage.fromId.toString() + '/' + chatMessage.toId.toString()).push();
                        var toref = firebase.database().ref('/user-messages/' + chatMessage.toId.toString() + '/' + chatMessage.fromId.toString()).push();
                        chatMessage.id = ref.getKey();
                        ref.set(
                            {
                                fromId: chatMessage.fromId,
                                id: chatMessage.id,
                                text: chatMessage.text,
                                timeStamp: chatMessage.timeStamp,
                                toId: chatMessage.toId
                            });
                        toref.set(
                            {
                                fromId: chatMessage.fromId,
                                id: chatMessage.id,
                                text: chatMessage.text,
                                timeStamp: chatMessage.timeStamp,
                                toId: chatMessage.toId
                            });

                    }, false)

                    reader.readAsDataURL(blob);

                }
            }
            recorder.start();
            control.setAttribute("class", "fas fa-stop fa-2x");
        }
        
    });
   
    if (recorder !== undefined) {
       
        if (control.getAttribute("class").indexOf("stop") !== -1) {
            recorder.stop();
            control.setAttribute("class", "fas fa-microphone fa-2x");
        } else {
            chunks = [];
            recorder.start();
            control.setAttribute('çlass', 'fas fa-stop fa-2x')

        }
    }
}

loadAllEmoji();












