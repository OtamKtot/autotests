package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;
import ru.comindware.PlatformComponents;

import static com.codeborne.selenide.Selenide.$;
import static com.codeborne.selenide.Selenide.$x;

public class ProjectPreparation {

    PlatformComponents platformComponents = new PlatformComponents();
    SelenideElement notificationContainer = platformComponents.notificationContainer(),
            addNewRecordToCollection = platformComponents.addNewRecordToCollection(3),
            collectionField1 = platformComponents.collectionField(8),
            collectionField2 = platformComponents.collectionField(9),
            firstElementFromDropdown = platformComponents.firstElementFromDropdown(),
            dropDown = platformComponents.dropDown(5),
            firstListCheckBox = platformComponents.firstListCheckBox(),
            verticalLayout = $x("//*[@class='layout__vertical-layout']"),
            radioButton1 = platformComponents.radioButtonYes(),
            radioButton2 = platformComponents.radioButton(2),
            radioButton3 = platformComponents.radioButton(3),
            createPhase1 = $x("//*[text() = 'Создать фазы']"),
            createPhase2 = $x("(//*[text() = 'Создать фазы'])[2]"),
            completeTask = $("[title=\"Завершить\"]");

    @Step("Добавить Исполнителя в коллекцию и создать фазы")
    public ProjectPreparation FillFormField(String fioIspolnitel) {
        addNewRecordToCollection.click();
        collectionField1.click();
        firstElementFromDropdown.click();
        collectionField2.click();
        dropDown.setValue(fioIspolnitel);
        firstListCheckBox.click();
        verticalLayout.click();
        radioButton1.click();
        radioButton2.click();
        radioButton3.click();
        createPhase1.click();
        createPhase2.click();
        return this;
    }

}
