package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;

import static com.codeborne.selenide.Selenide.$;
import static com.codeborne.selenide.Selenide.$x;

public class ApointDirector {
    SelenideElement notificationContainer = $(".notification-body_container"),
            addNewRecordToCollection = $x("(//*[@class='toolbar-btn toolbar-btn_none    toolbar-btn_action  '])[4]"),
            collectionField1 = $x("(//*[@class='js-visible-collection visible-collection ']/tr/td[2])[2]"),
            collectionField2 = $x("(//*[@class='js-visible-collection visible-collection ']/tr/td[3])[2]"),
            collectionField3 = $x("(//*[@class='js-visible-collection visible-collection ']/tr/td[4])[2]"),
            collectionField4 = $x("//*[@class='js-visible-collection visible-collection ']/tr/td[5]"),
            collectionField5 = $x("//*[@class='js-visible-collection visible-collection ']/tr/td[6]"),
            collectionField6 = $x("//*[@class='js-visible-collection visible-collection ']/tr/td[7]"),
            collectionField7 = $x("//*[@class='js-visible-collection visible-collection ']/tr/td[8]"),
            textField = $x("(//*[@class='input input_text js-input'])[7]"),
            verticalLayout = $x("//*[@class='layout__vertical-layout']"),
            oldDateTime = $(".day.old"),
            newDateTime = $(".day.new", 2),
            dropDown = $x("(//*[@class='js-input bubbles__input'])[2]"),
            firstElementFromDropdown = $(".dd-list__i.selected"),
            AddRecordToCollection = $x("(//*[@class='toolbar-btn toolbar-btn_none    toolbar-btn_action  '])[4]"),
            completeTask = $("[title=\"Завершить задачу\"]");

    @Step("Добавить руководителя в коллекцию")
    public ApointDirector FillFormField(String nameProject, String codeProject, String fioDirector) {
        addNewRecordToCollection.click();
        collectionField1.click();
        textField.setValue(codeProject);
        verticalLayout.click();
        collectionField2.click();
        textField.setValue(nameProject);
        verticalLayout.click();
        collectionField3.click();
        dropDown.setValue(fioDirector);
        firstElementFromDropdown.click();
        collectionField4.click();
        oldDateTime.click();
        collectionField5.click();
        newDateTime.click();
        collectionField6.click();
        collectionField7.click();
        firstElementFromDropdown.click();
        verticalLayout.click();
        return this;
    }
}
