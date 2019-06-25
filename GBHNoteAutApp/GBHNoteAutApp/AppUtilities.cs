using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBHNoteAutApp
{
    //bellow are all the methods to get elements within shadow doms
   public class AppUtilities
    {
        public void addNote(IJavaScriptExecutor js)
        {
            //Clicking button to add a note
            var addNote = js.ExecuteScript("return document.querySelector('note-app').shadowRoot.querySelector('paper-fab').click()");
         
           // var noteTexArea = js.ExecuteScript("return document.querySelector('note-app').shadowRoot.querySelector('na-editor').shadowRoot.querySelector('na-note').shadowRoot.querySelector('iron-autogrow-textarea').shadowRoot.querySelector('div').querySelector('textarea#textarea').shadowRoot.querySelector('div')");
        }

        public void editNote(IJavaScriptExecutor js)
        {
            var editNote = js.ExecuteScript("return document.querySelector('note-app').shadowRoot.querySelector('div.notes')." +
                "querySelector('na-note').click()");
        }

        public void deleteNote(IJavaScriptExecutor js)
        {
            var pressDeleteBtn = js.ExecuteScript("return document.querySelector('note-app').shadowRoot.querySelector('na-editor#editor.open')" +
                                                   ".shadowRoot.querySelector('div.controls').querySelector('paper-button').click()");
        }

        public void logOut(IJavaScriptExecutor js)
        {
            var logOutBtn = js.ExecuteScript("return document.querySelector('note-app').shadowRoot.querySelector('na-toolbar')" +
                                              ".shadowRoot.querySelector('paper-icon-button').click()");
        }
    }
}
