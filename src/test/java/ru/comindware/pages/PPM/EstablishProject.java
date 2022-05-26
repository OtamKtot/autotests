package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;

import static com.codeborne.selenide.Condition.text;
import static com.codeborne.selenide.Condition.visible;
import static com.codeborne.selenide.Selenide.$;
import static com.codeborne.selenide.Selenide.$x;
import static ru.comindware.utils.RandomUtils.getRandomInt;

public class EstablishProject {
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

    @Step("Заполнение формы и полей коллекции")
    public EstablishProject FillFormField() {
        addNewRecordToCollection.click();
        collectionField1.click();
        textField.setValue("11");
        verticalLayout.click();
        collectionField2.click();
        textField.setValue("TestName");
        verticalLayout.click();
        collectionField3.click();
        dropDown.setValue("Director");
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

    @Step("Завершить задачу")
    public EstablishProject CompleteTask() {
        completeTask.click();
        return this;
    }

    @Step("Задача завершена")
    public EstablishProject OperationComplete() {
        notificationContainer.shouldHave(text("Операция выполнена"));
        return this;
    }

}
