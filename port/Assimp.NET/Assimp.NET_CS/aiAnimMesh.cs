/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiAnimMesh : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiAnimMesh(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiAnimMesh obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiAnimMesh() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Assimp_NETPINVOKE.delete_aiAnimMesh(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiVector3D mVertices {
    set {
      Assimp_NETPINVOKE.aiAnimMesh_mVertices_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Assimp_NETPINVOKE.aiAnimMesh_mVertices_get(swigCPtr);
      aiVector3D ret = (cPtr == IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

  public aiVector3D mNormals {
    set {
      Assimp_NETPINVOKE.aiAnimMesh_mNormals_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Assimp_NETPINVOKE.aiAnimMesh_mNormals_get(swigCPtr);
      aiVector3D ret = (cPtr == IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

  public aiVector3D mTangents {
    set {
      Assimp_NETPINVOKE.aiAnimMesh_mTangents_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Assimp_NETPINVOKE.aiAnimMesh_mTangents_get(swigCPtr);
      aiVector3D ret = (cPtr == IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

  public aiVector3D mBitangents {
    set {
      Assimp_NETPINVOKE.aiAnimMesh_mBitangents_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Assimp_NETPINVOKE.aiAnimMesh_mBitangents_get(swigCPtr);
      aiVector3D ret = (cPtr == IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_aiColor4D mColors {
    set {
      Assimp_NETPINVOKE.aiAnimMesh_mColors_set(swigCPtr, SWIGTYPE_p_p_aiColor4D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Assimp_NETPINVOKE.aiAnimMesh_mColors_get(swigCPtr);
      SWIGTYPE_p_p_aiColor4D ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_p_aiColor4D(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_aiVector3D mTextureCoords {
    set {
      Assimp_NETPINVOKE.aiAnimMesh_mTextureCoords_set(swigCPtr, SWIGTYPE_p_p_aiVector3D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Assimp_NETPINVOKE.aiAnimMesh_mTextureCoords_get(swigCPtr);
      SWIGTYPE_p_p_aiVector3D ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_p_aiVector3D(cPtr, false);
      return ret;
    } 
  }

  public aiAnimMesh() : this(Assimp_NETPINVOKE.new_aiAnimMesh(), true) {
  }

  public bool HasPositions() {
    bool ret = Assimp_NETPINVOKE.aiAnimMesh_HasPositions(swigCPtr);
    return ret;
  }

  public bool HasNormals() {
    bool ret = Assimp_NETPINVOKE.aiAnimMesh_HasNormals(swigCPtr);
    return ret;
  }

  public bool HasTangentsAndBitangents() {
    bool ret = Assimp_NETPINVOKE.aiAnimMesh_HasTangentsAndBitangents(swigCPtr);
    return ret;
  }

  public bool HasVertexColors(uint pIndex) {
    bool ret = Assimp_NETPINVOKE.aiAnimMesh_HasVertexColors(swigCPtr, pIndex);
    return ret;
  }

  public bool HasTextureCoords(uint pIndex) {
    bool ret = Assimp_NETPINVOKE.aiAnimMesh_HasTextureCoords(swigCPtr, pIndex);
    return ret;
  }

}