﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Block
{
    // Object Variables
    private bool isTransparent;
    private GameObject objVar;
    private bool isLiquid;
    private bool hasCoordModifier;
    private float xModifier;
    private float zModifier;
    private float yModifier;


    public Block(bool isTransparent, GameObject objVar, bool isLiquid)
    {
        setTransparent(isTransparent);
        setGameObject(objVar);
        setIsLiquid(isLiquid);
        UnityEngine.Debug.Log("Created New Block Object.... IS TRANSPARENT: " + getIsTransparent() + " HAS GAME OBEJECT: " + getHasGameObject());
    }

    public Block(bool isTransparent, GameObject objVar, bool isLiquid, float xModifier, float zModifier, float yModifier){
        setTransparent(isTransparent);
        setGameObject(objVar);
        setIsLiquid(isLiquid);
        setHasCoordModifier(true);
        setxModifier(xModifier);
        setyModifier(yModifier);
        setzModifier(zModifier);
    }

    public Block(GameObject objVar)
    {
        setGameObject(objVar);
        setTransparent(false);
        UnityEngine.Debug.Log("Created New Block Object.... IS TRANSPARENT: " + getIsTransparent() + " HAS GAME OBEJECT: " + getHasGameObject());
    }

    public Block(bool isTransparent)
    {
        setTransparent(isTransparent);
        setGameObject(null);
        UnityEngine.Debug.Log("Created New Block Object.... IS TRANSPARENT: " + getIsTransparent() + " HAS GAME OBEJECT: " + getHasGameObject());
    }


    public void setTransparent(bool isTransparent)
    {
        this.isTransparent = isTransparent;
    }

    public void setHasCoordModifier(bool hasCoordModifier){
        this.hasCoordModifier = hasCoordModifier;
    }

    public void setxModifier(float xModifier){
        this.xModifier = xModifier;
    }

    public void setzModifier(float zModifier){
        this.zModifier = zModifier;
    }

    public void setyModifier(float yModifier){
        this.yModifier = yModifier;
    }

    public void setGameObject(GameObject objVar)
    {
        this.objVar = objVar;
    }

    public void setIsLiquid(bool isLiquid)
    {
        this.isLiquid = isLiquid;
    }

    public bool getIsLiquid()
    {
        return isLiquid;
    }

    public bool getIsTransparent()
    {
        return isTransparent;
    }

    public GameObject getGameObject()
    {
        return objVar;
    }

    public bool getHasGameObject()
    {
        return (objVar != null);
    }

    public bool getHasCoordModifier(){
        return hasCoordModifier;
    }

    public float getzModifier(){
        return zModifier;
    }

    public float getxModifier(){
        return xModifier;
    }

    public float getyModifier(){
        return yModifier;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
